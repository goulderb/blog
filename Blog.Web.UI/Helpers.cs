namespace Blog.Web.UI
{
    public static class Helpers
    {
        public static IDictionary<string, string?> ToDictionary(object obj)
        {
            return obj.GetType()
                .GetProperties()
                .ToDictionary(p => p.Name, p => p?.GetValue(obj)?.ToString());
        }
    }
}
