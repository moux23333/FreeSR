namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LeaveChallengeScRsp
	{
		[ProtoMember(9)] public int Retcode;
	}
	
}
