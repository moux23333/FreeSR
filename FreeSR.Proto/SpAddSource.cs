namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpAddSource
	{
		[ProtoMember(1)] public string Source;
		[ProtoMember(2)] public int SpAdd;
	}

}
