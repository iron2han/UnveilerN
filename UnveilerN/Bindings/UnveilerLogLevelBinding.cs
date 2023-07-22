using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using UnveilerN.Utils;
using LogLevelPair = System.Collections.Generic.KeyValuePair<string, UnveilerN.Utils.UnveilerLogLevel?>;

namespace UnveilerN.Bindings
{
    /// <summary>
    /// Unveiler 日志等级绑定到界面
    /// </summary>
    public class UnveilerLogLevelBinding : ReadOnlyCollection<LogLevelPair>
    {
        public static UnveilerLogLevelBinding Instance { get; } = new UnveilerLogLevelBinding();

        private UnveilerLogLevelBinding() : base(GetLogLevels().ToList())
        {
        }

        private static IEnumerable<LogLevelPair> GetLogLevels()
        {
            yield return new LogLevelPair("Default", null);

            foreach (var value in Enum.GetValues(typeof(UnveilerLogLevel)))
            {
                var name = Enum.GetName(typeof(UnveilerLogLevel), value);
                yield return new LogLevelPair(name, (UnveilerLogLevel)value);
            }
        }
    }
}
