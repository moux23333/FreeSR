namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Material
	{
		[ProtoMember(4)] public int Tid;
		[ProtoMember(5)] public int Num;
		[ProtoMember(9)] public long Jfhkdolijdi;
	}

}
