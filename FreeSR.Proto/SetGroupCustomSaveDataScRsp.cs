namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetGroupCustomSaveDataScRsp
	{
		[ProtoMember(5)] public int GroupId;
		[ProtoMember(1)] public int EntryId;
		[ProtoMember(10)] public int Retcode;
	}
	
}
