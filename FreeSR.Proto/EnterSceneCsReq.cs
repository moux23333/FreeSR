namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterSceneCsReq
	{
		[ProtoMember(14)] public int PLLGBEHDPDK;
		[ProtoMember(6)] public int EntryId;
	}
	
}
