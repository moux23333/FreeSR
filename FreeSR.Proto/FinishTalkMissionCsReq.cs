namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTalkMissionCsReq
	{
		[ProtoMember(11)] public List<BAGPFGMEOPD> EDDNGGNLBFC;
		[ProtoMember(13)] public int SubMissionId;
		[ProtoMember(15)] public string TalkStr;
	}
	
}
