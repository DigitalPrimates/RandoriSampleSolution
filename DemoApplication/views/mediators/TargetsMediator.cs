/***
 * Copyright 2012 LTN Consulting, Inc. /dba Digital Primates®
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * @author Michael Labriola <labriola@digitalprimates.net>
 */

using System;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using demo.services;
using randori.attributes;
using randori.behaviors;

namespace demo.views.mediators {

    public class TargetsMediator : AbstractMediator {

        [View]
        public SimpleList targetList;

        [Inject] 
        public TargetsService service;

        public override void setViewData(object viewData) {
            //We can optionally send in data when we select a view... this is where it ends up
        }

        protected override void onRegister() {
            var token = service.get();
            token.result += targetResults;
            /*
            var targetData = new TargetData[] {
                new TargetData{name = "Jaws", image = "assets/images/jaws.jpg", lastKnownLocation = "Unknown", status = "Unknown"},
                new TargetData{name = "Dr. Julius No", image = "assets/images/drno.jpg", lastKnownLocation = "Crab Key, Jamaica", status = "Deceased"},
                new TargetData{name = "Ernst Stavro Blofeld", image = "assets/images/blofeld.jpg", lastKnownLocation = "Baja, California", status = "Presumed Dead"}
            };

            targetList.data = targetData;
             */
        }

        private void targetResults(object result) {
            targetList.data = result.As<JsArray>();
        }
    }
}
