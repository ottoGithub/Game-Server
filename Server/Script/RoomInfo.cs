﻿namespace INFO
{
    class Room
    {
        public byte nowUser { get; set; }        // 방에 들어와 있는 유저 수
        public byte limitUser;      // 인원 한계

        public uint roomIdx;        // 방 번호
        public string roomName;     // 방 이름
        public string roomPW;       // 방 비번
    }
}
