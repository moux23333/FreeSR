namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetBasicInfoScRsp
	{
		[ProtoMember(3)] public long LastSetNicknameTime;
		[ProtoMember(15)] public int WeekCocoonFinishedCount;
		[ProtoMember(9)] public int ExchangeTimes;
		[ProtoMember(5)] public int CurDay;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(6)] public long NextRecoverTime;
		[ProtoMember(10)] public int GameplayBirthday;
		[ProtoMember(14)] public bool IsProtectedEquipmentRarity4;
	}
	
}
