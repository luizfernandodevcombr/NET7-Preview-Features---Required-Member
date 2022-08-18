// See https://aka.ms/new-console-template for more information
using NET7PreviewFeaturesConsoleApp;

Console.WriteLine("Hello, World!");

var featureOneRequiredMember = new FeatureOneRequiredMember()
{
    AttributeOne = "Some value"
};

var featureOneRequiredMemberErrorConstructor = new FeatureOneRequiredMemberErrorConstructor("teste"); //irá causar um erro de compilação
