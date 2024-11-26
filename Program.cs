var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if(app.Environment.IsDevelopment()){
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/",()=>{
    return "Sawvik";
});

app.MapGet("/hello",()=>{
    return "Hello from get method";
});

app.MapPost("/hello",()=>{
    return "Hello from Post method";
});

app.MapPut("/hello",()=>{
    return "Hello from Put method";
});

app.MapDelete("/hello",()=>{
    return "Hello from delete method";
});

app.MapGet("/change",()=>{
    return "Hello from get method 2";
});

app.MapGet("/saawvik",()=>{
    return "I am Sawvik Kar Dipto, Why do you want to get location ? ";
});

app.Run();