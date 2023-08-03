namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTalkMissionScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(10)] public List<BAGPFGMEOPD> EDDNGGNLBFC;
		[ProtoMember(9)] public int SubMissionId;
		[ProtoMember(14)] public string TalkStr;
	}
	
}
