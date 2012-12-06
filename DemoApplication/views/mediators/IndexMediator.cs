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

using SharpKit.Html;
using SharpKit.JavaScript;
using SharpKit.jQuery;
using randori.attributes;
using randori.behaviors;
using randori.behaviors.template;

namespace views.mediators {

    public class IndexMediator : AbstractMediator {

        [View]
        public jQuery header;

        [View]
        public jQuery menu;

        [View]
        public jQuery loginScreen;

        [View] 
        public ViewStack viewStack;

        protected override void onRegister() {
/*
            if ( template != null ) {
                template.data = (new { lastName = "Labriola", firstName = "Mike", className = "heavy", fragment = "fragment/plainHtml.html", contact = new { phone = "8005882300" } }).As<JsObject>();
            }
*/
            viewStack.addView("views/view1.html");
            viewStack.addView("views/view2.html");
        }

        public IndexMediator() {
        }
    }
}
