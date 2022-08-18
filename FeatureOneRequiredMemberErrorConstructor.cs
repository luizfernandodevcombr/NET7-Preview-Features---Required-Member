using System.Diagnostics.CodeAnalysis;

namespace NET7PreviewFeaturesConsoleApp
{
    public class FeatureOneRequiredMemberErrorConstructor
    {
        public required string AttributeOne { get; set; }

        [SetsRequiredMembers]
        public FeatureOneRequiredMemberErrorConstructor(string attributeOne)
        {
            this.AttributeOne = attributeOne;
        }
    }
}