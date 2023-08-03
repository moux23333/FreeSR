namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRndOptionScRsp
	{
		[ProtoMember(4)] public List<int> HMBAMLCFBHG;
		[ProtoMember(3)] public int Retcode;
	}
	
}
