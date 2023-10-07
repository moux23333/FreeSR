namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Vector
	{
		[ProtoMember(10)] public int y;
		[ProtoMember(9)] public int x;
		[ProtoMember(6)] public int z;
	}

}
