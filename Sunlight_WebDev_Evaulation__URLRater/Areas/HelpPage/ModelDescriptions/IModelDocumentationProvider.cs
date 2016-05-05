using System;
using System.Reflection;

namespace Sunlight_WebDev_Evaulation__URLRater.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}