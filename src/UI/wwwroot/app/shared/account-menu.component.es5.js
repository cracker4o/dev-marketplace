﻿"use strict";
var __extends = undefined && undefined.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() {
        this.constructor = d;
    }
    d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
};
var __decorate = undefined && undefined.__decorate || function (decorators, target, key, desc) {
    var c = arguments.length,
        r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc,
        d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = undefined && undefined.__metadata || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var Vue = require("vue");
var vue_class_component_1 = require("vue-class-component");
var AccountMenu = (function (_super) {
    __extends(AccountMenu, _super);
    function AccountMenu() {
        _super.apply(this, arguments);
    }
    AccountMenu.prototype.mounted = function () {
        this.message = "Hello World";
    };
    AccountMenu = __decorate([vue_class_component_1["default"]({
        el: "#account-menu"
    }), __metadata('design:paramtypes', [])], AccountMenu);
    return AccountMenu;
})(Vue);
Object.defineProperty(exports, "__esModule", { value: true });
exports["default"] = AccountMenu;
//# sourceMappingURL=accountMenu.js.map

