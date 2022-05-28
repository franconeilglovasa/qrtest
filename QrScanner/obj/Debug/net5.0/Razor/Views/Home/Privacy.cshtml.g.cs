#pragma checksum "/Users/franco/Projects/QrScanner/QrScanner/Views/Home/Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f41d2b4372bde148e4537d3c7d48abfc4340c53e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/franco/Projects/QrScanner/QrScanner/Views/_ViewImports.cshtml"
using QrScanner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/franco/Projects/QrScanner/QrScanner/Views/_ViewImports.cshtml"
using QrScanner.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41d2b4372bde148e4537d3c7d48abfc4340c53e", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9096470a5f465d5746fcb46f118dd1cb4f6b6475", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div ng-app=""app-qr"" ng-controller=""qrController as vm"">
    <button ng-click=""vm.start()"">Activate scanner</button>
    <p ng-hide=""vm.cameraRequested && !vm.cameraIsOn"">Your browser should ask for permission to use the camera.</p>
    <div>
        <bc-qr-reader
                      active=""vm.cameraRequested""
                      on-result=""vm.processURLfromQR""
                      on-error=""onError""
                      camera-status=""vm.cameraIsOn"" width=""200px"" height=""200px"">
        </bc-qr-reader>
    </div>
    <p>QR code detected!</p>
    <input type=""text"" ng-model=""vm.code"" id=""fname"" name=""fname"">
    <input type=""text"" ng-model=""vm.url"" id=""fname"" name=""fname"">

    <button ng-click=""vm.addQr(vm.code)""></button>


</div>




");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>var app = angular.module(""app-qr"", ['ngSanitize', 'ngAnimate', 'ngTouch', 'webcam',
            'bcQrReader']);
        //var app = angular.module(""app-image-viewer"", []);

        app.controller(""qrController"", function ($scope, $http, $timeout, $window, $filter, $location) {
            var vm = this;
            vm.processURLfromQR;
            vm.onError;
            vm.cameraIsOn;

            vm.cameraRequested = false;

            vm.start = function () {
                vm.cameraRequested = false
            }

            vm.processURLfromQR = function (url) {
               vm.code = url;
               vm.cameraRequested = false;
            }


            vm.addQr = function (qr) {

                console.log(qr);

                var data = {};
                data.id = 0;
                data.qr = qr;

                var apiUrl = ""Api/Data/AddQr"";
                vm.isBusy = true;
                $http({
                    method: 'post',
                    headers: {
        ");
                WriteLiteral(@"                ""Content-Type"": ""application/json"",
                        
                    },
                    url: apiUrl,
                    data: qr
                })
                    .then(function (response) {

                        if (response) {

                         
                        }

                    }, function (err) {
                        console.log(err);

                        vm.errorMessage = ""Failed to Add Qr"";
                        vm.successMessage = null;
                    }).finally(function () {
                        vm.isBusy = false;
                    });
            }

  


        });</script>


");
            }
            );
            WriteLiteral("\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
