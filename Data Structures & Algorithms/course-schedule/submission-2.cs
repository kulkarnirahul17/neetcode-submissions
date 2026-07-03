public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        if(prerequisites.Length == 0)
            return true;

        Dictionary<int, HashSet<int>> preMap = new();
        HashSet<int> visited = new();

        foreach(var prereq in prerequisites)
        {
            int currCourse = prereq[0];
            int prereqCourse = prereq[1];

            // Check if prereq already has curr course listed as prereq
            if( currCourse == prereqCourse)
                return false;
            
            if(!preMap.ContainsKey(currCourse))
                preMap[currCourse] = new HashSet<int>();
            preMap[currCourse].Add(prereqCourse);          
        }

        foreach(var item in preMap) {
            int courseId = item.Key;
            if(!dfs(courseId))
                return false;
        }
        return true;
        
        bool dfs(int courseId) {
            if(visited.Contains(courseId))
                return false;
            // Current course does not have any prerequisites.
            if(!preMap.ContainsKey(courseId) || preMap[courseId].Count == 0)
                return true;
            visited.Add(courseId);
            foreach(var c in preMap[courseId])
            {
                if(!dfs(c))
                    return false;                                
            }
            visited.Remove(courseId);
            return true;
        }
    }
}
