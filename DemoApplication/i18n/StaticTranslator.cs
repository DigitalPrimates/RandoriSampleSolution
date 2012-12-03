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
using randori.i18n;

/**No, you wouldnt do it this way, we are just demonstrating a point **/
namespace i18n {

    public class StaticTranslator : AbstractTranslator {

        public JsObject<JsObject<JsString>> translations; 


        public override JsArray<Translation> synchronousTranslate(JsString domain, JsArray<JsString> keys) {

            var domainKeys = translations[domain];
            var response = new JsArray<Translation>();

            if ( domainKeys != null ) {
                for ( var i=0; i<keys.length;i++) {
                    var translation = new Translation();
                    translation.key = keys[i];
                    translation.value = domainKeys[keys[i]];
                    response.push(translation);
                }
            }

            return response;
        }

        public override void translate(JsString domain, JsArray<JsString> keys) {
            var response = synchronousTranslate(domain, keys);

            translationResult(domain, response);
        }

        public StaticTranslator() {
            this.translations = new JsObject<JsObject<JsString>>();

            var labels = new JsObject<JsString>();
            labels["Greetings"] = "Howdy There";
            labels["Whatever"] = "Blah";

            var messages = new JsObject<JsString>();
            labels["ERROR"] = "There has been a rather large error";
            labels["LEAVE"] = "It would be best if you left now";

            translations["labels"] = labels;
            translations["messages"] = labels;
        }
    }
}
