public class TimeMap
{
    private record TimeValue(int timestamp, string value);

    Dictionary<string, List<TimeValue>> _map;

    public TimeMap()
    {
        _map = new();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!_map.ContainsKey(key))
        {
            _map.Add(key, new List<TimeValue>());
        }
        _map[key].Add(new TimeValue(timestamp, value));

    }

    public string Get(string key, int timestamp)
    {
        if (!_map.ContainsKey(key))
            return "";
        var timeValues = _map[key];
        int left = 0, right = timeValues.Count;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (timeValues[mid].timestamp <= timestamp)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        if (left == 0)
            return "";

        return timeValues[left - 1].value;
    }
}
