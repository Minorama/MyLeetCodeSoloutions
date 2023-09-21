string[] strs =  ["flower","flow","flight"];
// inisializing variables
string output = strs.Length == 1 ? strs[0] : "";
bool finding_prefix = output == "" ? true : false;
int itteration = 0;
int pre_high = 0;
//Creating a dictionary to store the letters and the number of times they appear
IDictionary<char,int> alpha = new Dictionary<char,int>(){
    {'a', 0},
    {'b', 0},
    {'c', 0},
    {'d', 0},
    {'e', 0},
    {'f', 0},
    {'g', 0},
    {'h', 0},
    {'i', 0},
    {'j', 0},
    {'k', 0},
    {'l', 0},
    {'m', 0},
    {'n', 0},
    {'o', 0},
    {'p', 0},
    {'q', 0},
    {'r', 0},
    {'s', 0},
    {'t', 0},
    {'u', 0},
    {'v', 0},
    {'w', 0},
    {'x', 0},
    {'y', 0},
    {'z', 0}
};
int max = 0;
char maxkey = ' ';

//Finds the prefix

while(finding_prefix){
    foreach(char key in alpha.Keys.ToList()) 
  {
    alpha[key] = 0;
  }
    /*Looping through the array of strings and adding the values 
    to the dictionary based on how many times a letter appears
    in the same position in the string
    */
    for(int i = 0; i < strs.Length; i++){
        if(itteration < strs[i].Length){
            alpha[strs[i][itteration]] += 1;
            if (strs[i].Contains(maxkey)){
                continue;
            }
            else{
                
            }
        }else{
            finding_prefix = false;
            goto loopend;
        }
    }
    //Contorlling how many times the loop runs
    max = alpha.Values.Max();
    if(pre_high > max || max < 2 || max != strs.Length){
        finding_prefix = false;
        break;
    }
    //Finding the max value in the dictionary and returning the key
    maxkey = alpha.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
    output += maxkey;
    
    //Incrementing variables
    itteration++;
    pre_high = alpha.Values.Max();
}
loopend:
Console.WriteLine(output);