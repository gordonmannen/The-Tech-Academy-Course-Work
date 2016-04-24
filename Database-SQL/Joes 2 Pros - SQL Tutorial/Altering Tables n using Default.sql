SELECT * FROM tblMovie
SELECT * FROM Movie


ALTER TABLE tblMovie
ADD m_Description Varchar (100) NULL

INSERT INTO tblMovie
VALUES (6, 'Fire Shaft', 75, 'R', 'Cool Pic about...')

DELETE tblMovie
WHERE m_id = 6

ALTER TABLE tblMovie
DROP COLUMN m_Description

ALTER TABLE tblMovie
Add m_Description Varchar (100) NOT NULL
DEFAULT 'Description Coming Soon'

INSERT INTO tblMovie
VALUES (6, 'Fire Shaft', 75, 'R', DEFAULT)

sp_rename 'tblMovie.m_Description', 'm_Teaser'

sp_rename 'tblMovie', 'Movie'

SELECT * FROM Movie

ALTER TABLE Movie
ADD m_Release Int NOT NULL
DEFAULT 2000
