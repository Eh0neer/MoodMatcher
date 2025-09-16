using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodMatcher.Domain
{
    public enum MediaType
    {
        Film,
        Series
    }

    public enum MoodTag
    {
        Anime, // Аниме
        Biographical, // биографический
        Action, // боевик
        Western, // вестерн
        Military, // военный
        Detective, // детектив
        Childrens, // детский
        Documentary, // документальный
        Drama, // драма
        Historical, // исторический
        FilmComic, // кинокомикс
        Comedy, // комедия
        Concert, // концерт
        ShortFilm, // короткометражный
        FilmCrime, // криминал
        Melodrama, // мелодрама
        Mysticism, // мистика
        Music, // музыка
        Cartoon, // мультфильм
        Musical, // мюзикл
        Science, // научный
        Noir, // нуар
        Adventure, // приключения
        RealityShow, // реалити-шоу
        Family, // семейный
        Sports, // спорт
        TalkShow, // ток-шоу
        Thriller, // триллер
        Horror, // ужасы
        ScienceFiction, // фантастика
        Fantasy, // фэнтези
        Erotica // эротика
    }

    public enum UserAction
    {
        [Description("Просмотрено")]
        Viewed,
        [Description("Оценено")]
        Rated,
        [Description("Добавлено в список желаемого")]
        AddedToWatchlist,
        [Description("Прокомментировано")]
        Commented,
        [Description("Удаленно из списока желаемого")]
        RemovedFromWatchlist,
        [Description("Комментарий удалён")]
        RemovedComment
    }
}
