﻿#region License
// The Developer Marketplace is a web application that allows individuals, 
// teams and companies share KanBan stories, cards, tasks and items from 
// their KanBan boards and Scrum boards. 
// All shared stories become available on the Developer Marketplace website
//  and software engineers from all over the world can work on these stories. 
// 
// Copyright (C) 2016 Tosho Toshev
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
// GitHub repository: https://github.com/cracker4o/dev-marketplace
// e-mail: cracker4o@gmail.com
#endregion
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddDefaultCountriesAndACompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AD','Andorra')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AE','United Arab Emirates')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AF','Afghanistan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AG','Antigua and Barbuda')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AI','Anguilla')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AL','Albania')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AM','Armenia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AN','Netherlands Antilles')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AO','Angola')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AQ','Antarctica')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AR','Argentina')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AS','American Samoa')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AT','Austria')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AU','Australia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AW','Aruba')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('AZ','Azerbaijan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BA','Bosnia and Herzegovina')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BB','Barbados')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BD','Bangladesh')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BE','Belgium')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BF','Burkina Faso')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BG','Bulgaria')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BH','Bahrain')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BI','Burundi')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BJ','Benin')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BM','Bermuda')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BN','Brunei')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BO','Bolivia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BR','Brazil')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BS','Bahamas')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BT','Bhutan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BV','Bouvet Island')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BW','Botswana')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BY','Belarus')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('BZ','Belize')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CA','Canada')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CC','Cocos Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CD','The Democratic Republic Of Congo')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CF','Central African Republic')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CG','Congo')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CH','Switzerland')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CI','Côte d''Ivoire')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CK','Cook Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CL','Chile')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CM','Cameroon')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CN','China')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CO','Colombia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CR','Costa Rica')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CV','Cape Verde')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CW','Curaçao')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CX','Christmas Island')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CY','Cyprus')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('CZ','Czech Republic')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('DE','Germany')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('DJ','Djibouti')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('DK','Denmark')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('DM','Dominica')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('DO','Dominican Republic')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('DZ','Algeria')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('EC','Ecuador')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('EE','Estonia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('EG','Egypt')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('EH','Western Sahara')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ER','Eritrea')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ES','Spain')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ET','Ethiopia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('FI','Finland')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('FJ','Fiji')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('FK','Falkland Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('FM','Micronesia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('FO','Faroe Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('FR','France')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GA','Gabon')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GB','United Kingdom')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GD','Grenada')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GE','Georgia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GF','French Guiana')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GH','Ghana')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GI','Gibraltar')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GL','Greenland')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GM','Gambia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GN','Guinea')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GP','Guadeloupe')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GQ','Equatorial Guinea')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GR','Greece')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GS','South Georgia And The South Sandwich Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GT','Guatemala')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GU','Guam')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GW','Guinea-Bissau')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('GY','Guyana')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('HK','Hong Kong')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('HM','Heard Island And McDonald Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('HN','Honduras')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('HR','Croatia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('HT','Haiti')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('HU','Hungary')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ID','Indonesia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IE','Ireland')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IL','Israel')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IM','Isle Of Man')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IN','India')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IO','British Indian Ocean Territory')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IQ','Iraq')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IS','Iceland')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('IT','Italy')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('JM','Jamaica')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('JO','Jordan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('JP','Japan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KE','Kenya')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KG','Kyrgyzstan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KH','Cambodia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KI','Kiribati')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KM','Comoros')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KN','Saint Kitts And Nevis')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KR','South Korea')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KW','Kuwait')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KY','Cayman Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('KZ','Kazakhstan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LA','Laos')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LB','Lebanon')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LC','Saint Lucia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LI','Liechtenstein')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LK','Sri Lanka')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LR','Liberia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LS','Lesotho')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LT','Lithuania')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LU','Luxembourg')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LV','Latvia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('LY','Libya')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MA','Morocco')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MC','Monaco')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MD','Moldova')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ME','Montenegro')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MG','Madagascar')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MH','Marshall Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MK','Macedonia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ML','Mali')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MM','Myanmar')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MN','Mongolia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MO','Macao')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MP','Northern Mariana Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MQ','Martinique')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MR','Mauritania')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MS','Montserrat')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MT','Malta')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MU','Mauritius')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MV','Maldives')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MW','Malawi')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MX','Mexico')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MY','Malaysia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('MZ','Mozambique')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NA','Namibia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NC','New Caledonia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NE','Niger')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NF','Norfolk Island')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NG','Nigeria')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NI','Nicaragua')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NL','Netherlands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NO','Norway')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NP','Nepal')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NR','Nauru')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NU','Niue')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('NZ','New Zealand')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('OM','Oman')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PA','Panama')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PE','Peru')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PF','French Polynesia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PG','Papua New Guinea')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PH','Philippines')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PK','Pakistan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PL','Poland')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PM','Saint Pierre And Miquelon')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PN','Pitcairn')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PR','Puerto Rico')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PS','Palestine')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PT','Portugal')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PW','Palau')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('PY','Paraguay')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('QA','Qatar')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('RE','Reunion')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('RO','Romania')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('RS','Serbia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('RU','Russia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('RW','Rwanda')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SA','Saudi Arabia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SB','Solomon Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SC','Seychelles')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SE','Sweden')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SG','Singapore')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SH','Saint Helena')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SI','Slovenia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SJ','Svalbard And Jan Mayen')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SK','Slovakia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SL','Sierra Leone')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SM','San Marino')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SN','Senegal')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SO','Somalia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SR','Suriname')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ST','Sao Tome And Principe')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SV','El Salvador')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SX','Sint Maarten (Dutch part)')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('SZ','Swaziland')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TC','Turks And Caicos Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TD','Chad')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TF','French Southern Territories')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TG','Togo')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TH','Thailand')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TJ','Tajikistan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TK','Tokelau')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TM','Turkmenistan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TN','Tunisia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TO','Tonga')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TR','Turkey')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TT','Trinidad and Tobago')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TV','Tuvalu')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TW','Taiwan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('TZ','Tanzania')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('UA','Ukraine')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('UG','Uganda')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('UM','United States Minor Outlying Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('US','United States')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('UY','Uruguay')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('UZ','Uzbekistan')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('VA','Vatican')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('VC','Saint Vincent And The Grenadines')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('VE','Venezuela')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('VG','British Virgin Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('VI','U.S. Virgin Islands')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('VN','Vietnam')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('VU','Vanuatu')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('WF','Wallis And Futuna')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('WS','Samoa')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('XK','Kosovo')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('YE','Yemen')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('YT','Mayotte')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ZA','South Africa')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ZM','Zambia')");
            migrationBuilder.Sql("INSERT INTO Country VALUES ('ZW','Zimbabwe')");

            migrationBuilder.Sql("INSERT INTO Company (Description, Email, IsoCountryCode, Location, Name, Url) VALUES (null, 'noemail@devmarketplace.com', 'US', '', 'No Company', '')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Company WHERE Email = 'noemail@devmarketplace.com'");
            migrationBuilder.Sql("DELETE FROM Country");
        }
    }
}
