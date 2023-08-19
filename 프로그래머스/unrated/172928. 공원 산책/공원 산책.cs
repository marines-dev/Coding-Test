using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
        int[] answer = new int[2];
        
        for(int y = 0; y < park.Length; ++y)
        {
            int x = park[y].IndexOf("S");
            if(x != -1)
            {
                answer[0] = y;
                answer[1] = x;
                break;
            }
        }
        
        foreach(string route in routes)
        {
            string dir = route.Split(' ')[0];
            int dist = int.Parse(route.Split(' ')[1]);
            int y = 0;
            int x = 0;
            
            switch(dir)
            {
                case "N":
                    {
                        y -= dist;
                        dist = y;
                    }
                    break;
                    
                case "S":
                    {
                        y += dist;
                        dist = y;
                    }
                    break;
                    
                case "W":
                    {
                        x -= dist;
                        dist = x;
                    }
                    break;
                    
                case "E":
                    {
                        x += dist;
                        dist = x;
                    }
                    break;
            }

            if((y + answer[0]) >= 0 && (y + answer[0]) < park.Length 
               && (x + answer[1]) >= 0 && (x + answer[1]) < park[0].Length)
            {
               char pos = park[answer[0]][answer[1]]; 
                if(dist < 0)
                {
                    for(int i = -1; i >= dist; --i)
                    {
                        pos = (dist == y) ? park[answer[0] + i][answer[1]] : park[answer[0]][answer[1] + i];
                        if(pos == 'X')
                            break;
                    }
                }
                else
                {
                    for(int i = 1; i <= dist; ++i)
                    {
                        pos = (dist == y) ? park[answer[0] + i][answer[1]] : park[answer[0]][answer[1] + i];
                        if(pos == 'X')
                            break;
                    }
                }
                
                if(pos != 'X')
                {
                    answer[0] += y;
                    answer[1] += x;
                }
            }
        }
        return answer;
    }
}