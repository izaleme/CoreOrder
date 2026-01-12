using System.Reflection;
using System.Text;

//try
//{
    var builder = WebApplication.CreateBuilder(args);

    // Services
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Pipeline
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseAuthorization();

    app.MapControllers();
    app.MapGet("/", () => "Auth Service is running!");

    app.Run();
//}
//catch (ReflectionTypeLoadException ex)
//{
//    StringBuilder sb = new StringBuilder();
//    foreach (Exception exSub in ex.LoaderExceptions)
//    {
//        sb.AppendLine(exSub.Message);
//        FileNotFoundException exFileNotFound = exSub as FileNotFoundException;
//        if (exFileNotFound != null)
//        {
//            if (!string.IsNullOrEmpty(exFileNotFound.FusionLog))
//            {
//                sb.AppendLine("Fusion Log:");
//                sb.AppendLine(exFileNotFound.FusionLog);
//            }
//        }
//        sb.AppendLine();
//    }
//    string errorMessage = sb.ToString();
//}