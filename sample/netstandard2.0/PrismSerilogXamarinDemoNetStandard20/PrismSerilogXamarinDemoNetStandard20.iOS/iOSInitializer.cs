#region Copyright 2019-2021 C. Augusto Proiete & Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#endregion

using Prism;
using Prism.Ioc;
using Serilog;
using Serilog.Core;

namespace PrismSerilogXamarinDemoNetStandard20.iOS
{
    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations

            var stringBuilder = new System.Text.StringBuilder();
            var messages = new System.IO.StringWriter(stringBuilder);
            Log.Logger =
                new LoggerConfiguration()
                    .WriteTo.NSLog()
                    .WriteTo.TextWriter(messages)
                    .MinimumLevel.Debug()
                    .CreateLogger();
            containerRegistry.RegisterInstance(messages);
        }
    }
}
