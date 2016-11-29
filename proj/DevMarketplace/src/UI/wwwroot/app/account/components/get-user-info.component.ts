﻿import { Component, OnInit } from "@angular/core";
import { AccountService } from "../services/account.service";
import { CurrentUser } from "../models/current-user.model";
import { TranslateService } from "ng2-translate";

@Component({
    selector: "account-user-info",
    templateUrl: "./app/account/templates/get-user-info.component.html",
    providers: [AccountService]
})

export class GetUserInfoComponent implements OnInit {
    private user: CurrentUser = new CurrentUser();

    constructor(private accountService: AccountService, private translate: TranslateService) {
        translate.addLangs(["en"]);
        translate.setDefaultLang("en");

        let browserLang : string = translate.getBrowserLang();
        translate.use(browserLang.match(/en/) ? browserLang : "en");
    }

    ngOnInit(): void {
        this.accountService.getCurrentUser().subscribe(
            (userResponse: CurrentUser) => { this.user = userResponse; },
            (error: any) => console.log(<any>error));
    }
}