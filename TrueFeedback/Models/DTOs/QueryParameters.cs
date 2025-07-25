﻿public class QueryParameters
{
    public string? Search { get; set; }
    public string? SortBy { get; set; } 
    public bool SortDescending { get; set; } = false;

    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}