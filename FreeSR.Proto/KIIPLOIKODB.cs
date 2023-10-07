namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class KIIPLOIKODB
	{
		[ProtoMember(6)] public string Name;
		[ProtoMember(8)] public int Index;
	}

}
