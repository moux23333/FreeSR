namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetBasicInfoScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(13)] public int WeekCocoonFinishedCount;
		[ProtoMember(7)] public int CurDay;
		[ProtoMember(15)] public int NextRecoverTime;
		[ProtoMember(12)] public PlayerSettingInfo PlayerSettingInfo;
		[ProtoMember(2)] public int GameplayBirthday;
		[ProtoMember(14)] public int LastSetNicknameTime;
		[ProtoMember(3)] public int ExchangeTimes;
	}

}
