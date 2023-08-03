namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RogueChallengeRefreshAssistListScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(5)] public List<KHPHDKLCJGM> DHLCDINCAHC;
	}
	
}
