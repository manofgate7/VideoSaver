-- Table: public.Video

-- DROP TABLE IF EXISTS public."Video";

CREATE TABLE IF NOT EXISTS public."Video"
(
    "VideoId" bigint NOT NULL,
    "videoName" text COLLATE pg_catalog."default",
    "VideoBlob" bytea,
    "EnteredDate" timestamp(5) without time zone,
    "ChangedDate" timestamp(5) without time zone,
    CONSTRAINT "Video_pkey" PRIMARY KEY ("VideoId")
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."Video"
    OWNER to postgres;