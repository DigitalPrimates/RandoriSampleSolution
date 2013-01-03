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
using SharpKit.Html;
using SharpKit.JavaScript;
using demo.services.serializer;
using randori.service;

namespace demo.services {

    [JsType(JsMode.Prototype, Export = false, Name = "Object")]
    public class TargetData {
        public string name;
        public string image;
        public string lastKnownLocation;
        public string status;
    }

    public class TargetsService {
        readonly TargetParser parser;

        public string url { get; set; }

        public AbstractToken get() {
            var serviceToken = new ServiceToken();
            var request = new XMLHttpRequest();
            request.open("GET", url, true );
            request.onreadystatechange += serviceToken.onReadyStateChange;

            request.send("");

            return parser.createToken(serviceToken);
        }

        public TargetsService( TargetParser parser ) {
            this.parser = parser;
        }
    }
}
