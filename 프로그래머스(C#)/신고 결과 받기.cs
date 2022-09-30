using System;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] id_list_count = new int[id_list.Length];
        int[] report_count = new int[id_list.Length];
        int[] answer = new int[id_list.Length];
        report = report.Distinct().ToArray();
        
        string str = string.Join("," , report);
        string[] subs = str.Split(" ");
        str = string.Join(",", subs);
        subs = str.Split(",");
        
        for (int i = 0; i < id_list.Length; i++)
        {
            for (int j = 1; j < subs.Length; j+=2)
            {
                if (id_list[i] == subs[j])
                    report_count[i] += 1;
            }
        }
        
        string[] report_name = new string[report_count.Where(x => x >= k).Count()];
        int rn_count = 0;
        
        for (int i = 0; i < report_count.Length; i++)
        {
            if(report_count[i] >= k)
            {
                report_name[rn_count] = id_list[i];
                rn_count++;
            }
        }
        
        for (int i = 0; i < report_name.Length; i++)
        {
            for (int j = 1; j < subs.Length; j += 2)
            {
                if (report_name[i] == subs[j])
                    answer[Array.IndexOf(id_list, subs[j - 1])] += 1 ;
            }
        }
        return answer;
    }
}
