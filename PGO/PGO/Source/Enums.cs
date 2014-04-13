namespace PGO.Source
{
    public enum TableType
    {
        None,
        People,
        Pgo,
        House,
        Land,
        PgoType,
        Village,
        Street,
        Work,
        Education,
        Document,
        Family,
        Registration,
        Benefit
    }
    public enum StateOfClick
    {
        Click,
        Select
    }
    public enum WorkState
    {
        Insert,
        Update
    }

    public enum TypeFilter
    {
        Date,
        Text
    }

    public enum TypeFilterDate
    {
        Min = 0,
        Max = 1,
        Valid = 2,
        Not = 3
    }
    public enum TypeFilterText
    {
        LikeC   = 0,
        LikeR   = 1,
        LikeL   = 2,
        Valid   = 3,
        Not     = 4
    }
}
