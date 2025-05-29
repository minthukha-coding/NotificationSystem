using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationSystem.Core.Templates;

public class RazorTemplateRenderer
{
    public readonly RazorLight.RazorLightEngine _engine;

    public RazorTemplateRenderer()
    {
        _engine = new RazorLight.RazorLightEngineBuilder()
            .UseEmbeddedResourcesProject(typeof(RazorTemplateRenderer))
            .UseMemoryCachingProvider()
            .Build();
    }

    //public async Task<string> RenderAsync(string templateKey, object model)
    //{
    //    return await _engine.CompileRenderAsync(templateKey, templateKey, model);
    //}
}
