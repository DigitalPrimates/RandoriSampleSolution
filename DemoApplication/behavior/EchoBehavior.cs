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
using guice;
using guice.reflection;
using guice.resolver;
using randori.attributes;
using randori.behaviors;
using randori.content;

namespace behavior {
    class EchoBehavior : AbstractBehavior  {
        /*
        [Inject]
        public void builder(ContentLoader contentLoader) {
            HtmlContext.alert("Content Loader injected? " + contentLoader );
        }

        [Inject]
        public void builderPlus(ContentLoader contentLoader, ClassResolver resolver) {
            HtmlContext.alert("Content Loader and ClassResolver injected? " + contentLoader + ' ' + resolver);
        }*/

        protected override void onRegister() {
            decoratedElement.innerText = getName(this.As<JsObject>());
        }

        protected JsString getName(JsObject instance) {
            var dependency = new TypeDefinition(instance["constructor"]);
            return dependency.getClassName();
        }

    }
}
