namespace OpenLabel;

/// <summary>
/// 
/// </summary>
public class Die : Base
{
    public string? StockId { get; set; }
    public int ShapeId { get; set; }
    public Shape Shape
    {
        get { return (Shape)ShapeId; }
        set { ShapeId = (int)value; }
    }

    public decimal SizeAcross { get; set; }
    public decimal SizeAround { get; set; }

    public int CornerShapeId { get; set; }
    public CornerShape CornerShape
    {
        get { return (CornerShape)CornerShapeId; }
        set { CornerShapeId = (int)value; }
    }

    public decimal CornerRadius { get; set; }
}