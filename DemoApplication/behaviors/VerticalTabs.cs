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
using randori.attributes;
using randori.behaviors;
using randori.dom;

namespace demo.behaviors {
    [JsType(JsMode.Prototype, Export = false)]
    public delegate void MenuItemSelected(MenuItem menuData);

    [JsType(JsMode.Json, Export = false, Name = "Object")]
    public class MenuItem {
        public string name;
        public string url;
    }

    public class VerticalTabs : List {

        public MenuItemSelected menuItemSelected;

        public override void renderList() {
            base.renderList();

            var children = decoratedNode.children();
            var first = children.eq( 0 );
            var last = children.eq(children.length-1);

            first.addClass( "first" );
            last.addClass("last");
        }

        protected override void onRegister() {
            this.listChanged += listChangedHandler;
            base.onRegister();
        }

        private void listChangedHandler(int index, JsObject data) {
            if (menuItemSelected != null && data != null) {
                var menuItem = new MenuItem {name = data[ "name" ].As<string>(), url = data[ "url" ].As<string>()};
                menuItemSelected(menuItem);
            }
        }

        public VerticalTabs(DomWalker domWalker)
			: base(domWalker)
		{
        }
    }
}
