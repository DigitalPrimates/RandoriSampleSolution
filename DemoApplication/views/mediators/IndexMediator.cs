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

    [JsType(JsMode.Prototype, NativeJsons=true)]
    public class IndexMediator : AbstractMediator {

        [View]
        public jQuery welcomeMessage;

        [View(required = false)]
        public jQuery welcomeMessage2;

        [View]
        public TemplateRenderer template;

        protected override void onRegister() {

            template.data = (new { lastName = "Labriola", firstName = "Mike", className = "heavy", contact = new { phone = "8005882300" } }).As<JsObject>();


            HtmlContext.alert( "All registered 2 " + welcomeMessage.text() );
        }

        public IndexMediator(HtmlElement body)
            : base(body) {
        }
    }
}
