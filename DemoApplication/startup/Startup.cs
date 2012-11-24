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

using SharpKit.JavaScript;
using SharpKit.jQuery;
using guice;
using randori.styles;

namespace demo.startup {
    [JsType(JsMode.Global)]
    public class Startup : jQueryContext {
        static void Main() {
            //Create the injector that will be used in the application
            var guiceJs = new GuiceJs();
            var injector = guiceJs.createInjector(new DemoModule());

            //Load the style sheets and extract our needed information
            var styleManager = (StyleBehaviorManager)injector.getInstance(typeof(StyleBehaviorManager));
            styleManager.parseAndReleaseNodes(J("link"));

            var body = J("body");
        }
    }
}
