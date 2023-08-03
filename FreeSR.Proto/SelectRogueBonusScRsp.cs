namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SelectRogueBonusScRsp
	{
		[ProtoMember(12)] public int DialogueEventId;
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(5)] public DialogueResultInfo ResultInfo;
	}
	
}
