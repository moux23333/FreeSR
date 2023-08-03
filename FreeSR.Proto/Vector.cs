namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Vector
	{
		[ProtoMember(9, DataFormat = DataFormat.ZigZag)] public int X;
		[ProtoMember(10, DataFormat = DataFormat.ZigZag)] public int Y;
		[ProtoMember(1, DataFormat = DataFormat.ZigZag)] public int Z;
	}
	
}
