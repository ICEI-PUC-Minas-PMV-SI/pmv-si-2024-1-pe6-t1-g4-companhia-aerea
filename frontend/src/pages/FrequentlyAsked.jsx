import{ useState } from "react";
import {
  Box,
  Container,
  Typography,
  IconButton,
  Collapse,
} from "@mui/material";
import { alpha } from "@mui/material";
import { ExpandMore as ExpandMoreIcon } from "@mui/icons-material";
import faqData from "../data/faq.json";

function FAQPage() {
  const [expanded, setExpanded] = useState(null);

  const handleExpand = (questionNumber) => {
    if (expanded === questionNumber) {
      setExpanded(null);
    } else {
      setExpanded(questionNumber);
    }
  };

  return (
    <Box
      id="faq"
      sx={(theme) => ({
        width: "100%",
        backgroundImage:
          theme.palette.mode === "light"
            ? "linear-gradient(180deg, #CEE5FD, #FFF)"
            : `linear-gradient(#02294F, ${alpha("#090E10", 0.0)})`,
        backgroundSize: "100% 20%",
        backgroundRepeat: "no-repeat",
      })}
    >
      <Container
        sx={{
          display: "flex",
          flexDirection: "column",
          alignItems: "center",
          pt: { xs: 14, sm: 20 },
          pb: { xs: 8, sm: 12 },
        }}
      >
        {faqData.FAQ.map((item) => (
          <Box key={item.question_number} sx={{ width: "100%", my: 2 }}>
            <Box
              sx={{
                display: "flex",
                alignItems: "center",
                justifyContent: "space-between",
                borderBottom: "1px solid #ccc",
                pb: 1,
              }}
            >
              <Typography variant="h6">{`${item.question_number}. ${item.question}`}</Typography>
              <IconButton
                aria-label="expand"
                onClick={() => handleExpand(item.question_number)}
                sx={{
                  transform:
                    expanded === item.question_number
                      ? "rotate(180deg)"
                      : "rotate(0deg)",
                }}
              >
                <ExpandMoreIcon />
              </IconButton>
            </Box>
            <Collapse in={expanded === item.question_number}>
              <Typography variant="body1" sx={{ mt: 1 }}>
                {item.answer}
              </Typography>
            </Collapse>
          </Box>
        ))}
      </Container>
    </Box>
  );
}

export default FAQPage;
