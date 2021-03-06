param (
    [switch] $noinit,

    [switch] $noDbConfig
)

#verifies all prerequisites
function checkForNetCore () {

    #checking for .NetCore runtime
    if((Test-Path "C:\Program Files\dotnet\shared\Microsoft.NETCore.App\1.1.1") -eq $false) {
        Write-Output "The .Net Core runtime 1.1.1 is not installed on your machine.`r`nPlease get it from here: 'https://go.microsoft.com/fwlink/?linkid=843433' ";
        exit;
    }

    #.NetCore SDK
    if((Test-Path "C:\Program Files\dotnet\sdk\1.0.3") -eq $false -and (Test-Path "C:\Program Files\dotnet\sdk\1.0.2") -eq $false) {
        Write-Output "The .Net Core SDK is not installed on your machine.`r`nPlease get it from here: 'https://go.microsoft.com/fwlink/?linkid=843448' "
        exit;
    }

    if((Test-Path "C:\Program Files\nodejs") -eq $false) {
        Write-Output "NodeJS is required. Please install."
        exit;
    }

    npm install gulp -g
}

function configureDatabase([string] $projectFolder, [string] $connectionString) {
    Push-Location $projectFolder

    $appSettings = (Get-Content "appsettings.json" | Out-String | ConvertFrom-Json)
    $appSettings.ConnectionStrings.Default = $connectionString;
    $appSettings | ConvertTo-Json -depth 100 | Out-File "appsettings.json" -Force    

    Pop-Location
}

function buildProject([string] $folder, [string] $projectName) {
    Push-Location $folder
    
    Write-Output "Restoring nuget packages for $projectName"
    dotnet restore;

    Write-Output "Building $projectName"
    dotnet build;

    if($LASTEXITCODE -ne 0) {
        exit;
    }

    Write-Output "Running $projectName"
    Start-Process powershell {dotnet run};
    Pop-Location;
}

#main routine
function main() {
    if ([System.IntPtr]::Size -eq 4) 
    { 
        Write-Output "You have a 32 bit OS. This script only supports 64 bit OS. Please build the project manually or upgrade your Windows to 64 bit."
        return;
    }

    if($noinit -eq $false) {
        checkForNetCore;
    }

    if($noDbConfig -eq $false) {
        $connectionString = Read-Host -Prompt "Please set a connection string to an empty or existing database"
        configureDatabase -projectFolder ".\src\RestServices\" -connectionString $connectionString;
        configureDatabase -projectFolder ".\src\UI\" -connectionString $connectionString;
    }
    
    buildProject -folder ".\src\RestServices\" -projectName "RestServices"

    Push-Location ".\src\UI\"
        npm  install
        gulp -b ".\" --color --gulpfile gulpfile.js copy-all
        gulp -b ".\" --color --gulpfile gulpfile.js sass
    Pop-Location

    buildProject -folder ".\src\UI\" -projectName "DevMarketplace"

    Write-Output "All Done"

    $text = @"
,---,---,---,---,---,---,---,---,---,---,---,---,---,-------,
| ~ | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 0 | [ | ] | <-    |
|---'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-----|
| ->| | " | , | . | P | Y | F | G | C | R | L | / | = |  \  |
|-----',--',--',--',--',--',--',--',--',--',--',--',--'-----|
| Caps | A | O | E | U | I | D | H | T | N | S | - |  Enter |
|------'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'-,-'--------|
|        | ; | Q | J | K | X | B | M | W | V | Z |          |
|------,-',--'--,'---'---'---'---'---'---'-,-'---',--,------|
| ctrl |  | alt |                          | alt  |  | ctrl |
'------'  '-----'--------------------------'------'  '------'
"@
    Write-Output $text
}

main;