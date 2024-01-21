namespace OpenLabel;

/// <summary>
/// Label
/// </summary>
public class Label
{
    public int ShapeId { get; set; }
    public Shape Shape
    {
        get { return (Shape)ShapeId; }
        set { ShapeId = (int)value; }
    }

    public int UnwindDirectionId { get; set; }
    public UnwindDirection UnwindDirection
    { 
        get { return (UnwindDirection)UnwindDirectionId; } 
        set { UnwindDirectionId = (int)value; } 
    }
    
    public decimal Height { get; set; }
    public decimal Width { get; set; }
    
    public int MaterialId { get; set; }
    public int FinishId { get; set; }

    public int CornerShapeId { get; set; }
    public CornerShape CornerShape { 
        get { return (CornerShape)CornerShapeId; } 
        set { CornerShapeId = (int)value; }
    }
    
    public decimal CornerRadius { get; set; }
}