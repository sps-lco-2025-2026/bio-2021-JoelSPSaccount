// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics.CodeAnalysis;

Dictionary<string,int> Cashe = [];
List<string> PrevValues= [];
(Dictionary<string,int>,List<string>,int) function(Dictionary<string,int> Cashe, List<string> PreValues, int layer)
{
    foreach (string Order in PreValues)
    {
        string newOrder;
        // Add:
        newOrder = Order + ('A'+Order.Count());
        function();
        // Swap:
        newOrder = "";
        // Rotate:
    }
    return (Cashe,PreValues,layer+1);
}