namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class WaitDelResource
	{
		[ProtoMember(8)] public int Num;
		[ProtoMember(9)] public int Tid;
	}
	
}
