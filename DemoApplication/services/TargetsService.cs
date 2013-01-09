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
using demo.services.parser;
using randori.async;
using randori.service;

namespace demo.services {

    [JsType(JsMode.Json, Export = false, Name = "Object")]
    public class TargetData {
        public string name;
        public string image;
        public string lastKnownLocation;
        public string status;
    }

    public class TargetsService : AbstractService {
        readonly ServiceConfig config;
        readonly TargetsParser targets;

        public string path { get; set; }

        public Promise<JsArray<TargetData>> get() {
            var promise = sendRequest("GET", config.protocol, config.host, config.port, path);
            var parserPromise = promise.then<JsArray<TargetData>>( targets.parseResult );

            return parserPromise;
        }

        public TargetsService(XMLHttpRequest xmlHttpRequest, ServiceConfig config, TargetsParser targets) 
            : base( xmlHttpRequest ) {
            this.config = config;
            this.targets = targets;
            this.path = "assets/data/targets.txt";
        }
    }
}
