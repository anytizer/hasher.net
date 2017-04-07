-- MariaDB/MySQL Server
-- @see https://dev.mysql.com/doc/refman/5.7/en/encryption-functions.html

SELECT SHA('test');        -- a94a8fe5ccb19ba61c4c0873d391e987982fbbd3
SELECT SHA1('test');       -- a94a8fe5ccb19ba61c4c0873d391e987982fbbd3

SELECT SHA2('test', 512);  -- ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff
SELECT SHA2('test', 384);  -- 768412320f7b0aa5812fce428dc4706b3cae50e02a64caa16a782249bfe8efc4b7ef1ccb126255d196047dfedf17a0a9
SELECT SHA2('test', 256);  -- 9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08
SELECT SHA2('test', 224);  -- 90a3ed9e32b2aaf4c61c410eb925426119e1a9dc53d4286ade99a809
SELECT SHA2('test', 0);    -- 9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08

-- @see https://md5hashing.net/hash/md5/098f6bcd4621d373cade4e832627b4f6
SELECT MD5('test'); -- 098f6bcd4621d373cade4e832627b4f6
