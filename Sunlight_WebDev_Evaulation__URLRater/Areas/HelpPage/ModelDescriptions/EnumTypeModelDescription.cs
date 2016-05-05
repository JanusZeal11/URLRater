using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Sunlight_WebDev_Evaulation__URLRater.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}