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

    public async Task<string> RenderTemplateAsync<T>(string templateKey, string templateContent, T model)
    {
        var template = await _engine.CompileTemplateAsync(templateContent);
        return await _engine.RenderTemplateAsync(template,model);
    }
}