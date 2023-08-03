namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetCurChallengeScRsp
	{
		[ProtoMember(5)] public int Retcode;
		[ProtoMember(10)] public CurChallenge CurChallenge;
	}
	
}
