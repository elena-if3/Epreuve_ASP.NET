namespace ASP.Handlers
{
    public static class FormFileHandler
    {
        public static async Task SaveFile(this IFormFile file)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/assets/imgs", file.FileName);
            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }
    }
}
