﻿using System.Collections.Generic;
using System.Web.Routing;

namespace Glimpse.AspNet.Model
{
    public class RouteModel
    {
        public RouteModel(
            bool matchesCurrentRequest,
            string area,
            string url, 
            List<RouteDataItemModel> routeData, 
            RouteValueDictionary constraints, 
            RouteValueDictionary datatokens, 
            bool isFirstMatch)
        {
            MatchesCurrentRequest = matchesCurrentRequest;
            Area = area;
            URL = url;
            RouteData = routeData;
            Constraints = constraints;
            DataTokens = datatokens;
            IsFirstMatch = isFirstMatch;
        }

        public RouteModel(bool matchesCurrentRequest)
        {
            MatchesCurrentRequest = matchesCurrentRequest;
        }

        public bool MatchesCurrentRequest { get; set; }
        public string Area { get; set; }
        public string URL { get; set; }
        public List<RouteDataItemModel> RouteData { get; set; }
        public RouteValueDictionary Constraints { get; set; }
        public RouteValueDictionary DataTokens { get; set; }
        public bool IsFirstMatch { get; set; }
    }

    public class RouteDataItemModel
    {
        public RouteDataItemModel(string key, object value, object defaultValue)
        {
            PlaceHolder = key;
            ActualValue = value;
            DefaultValue = defaultValue;
        }

        public string PlaceHolder { get; set; }
        public object DefaultValue { get; set; }
        public object ActualValue { get; set; }
    }
}
