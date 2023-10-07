namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class WaitDelResource
	{
		[ProtoMember(12)] public int Num;
		[ProtoMember(9)] public int Tid;
	}

}
