namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SelectRogueBonusCsReq
	{
		[ProtoMember(6)] public int DialogueEventId;
	}
	
}
