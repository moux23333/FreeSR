namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetLanguageCsReq
	{
		[ProtoMember(5)] public Language Language;
	}
	
}
